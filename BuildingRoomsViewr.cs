using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System;

namespace DXApplication1
{
    public partial class BuildingRoomsViewr : XtraForm
    {
        private readonly string _connectionString = "Server=.;Database=DisplayRooms;Trusted_Connection=True;";
        private DataTable _buildings;
        private DataTable _rooms;

        public BuildingRoomsViewr()
        {
            InitializeComponent();
            InitializeUI();
        }

        private void InitializeUI()
        {
            LoadBuildings();
            this.BackColor = Color.GhostWhite;
        }

        private void LoadBuildings()
        {
            try
            {
                const string query = "SELECT BuildingName FROM Buildings";
                _buildings = ExecuteQuery(query);

                if (_buildings != null)
                {
                    comboBoxBuildings.Properties.Items.Clear();
                    foreach (DataRow row in _buildings.Rows)
                    {
                        comboBoxBuildings.Properties.Items.Add(row["BuildingName"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                ShowError("Error loading buildings", ex);
            }
        }

        private void ComboBoxBuildings_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxBuildings.SelectedIndex >= 0)
            {
                string selectedBuildingName = comboBoxBuildings.SelectedItem.ToString();
                LoadRooms(selectedBuildingName);
            }
        }

        private void LoadRooms(string buildingName)
        {
            try
            {
                const string query = @"
                    SELECT RoomId, RoomName, Capacity 
                    FROM Rooms 
                    WHERE BuildingId = (SELECT BuildingId FROM Buildings WHERE BuildingName = @BuildingName)";

                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    var adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@BuildingName", buildingName);

                    _rooms = new DataTable();
                    adapter.Fill(_rooms);

                    treeListRooms.DataSource = _rooms;
                }
            }
            catch (Exception ex)
            {
                ShowError("Error loading rooms", ex);
            }
        }

        private DataTable ExecuteQuery(string query)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    var adapter = new SqlDataAdapter(query, connection);
                    var dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                ShowError("Error executing query", ex);
                return null;
            }
        }

        private void ShowError(string message, Exception ex)
        {
            XtraMessageBox.Show($"{message}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
