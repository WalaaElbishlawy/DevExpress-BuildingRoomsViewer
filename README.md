# DevExpress-BuildingRoomViewer

## Usage
This project demonstrates how to create a Building Room Viewer application using DevExpress WinForms controls.

## Requirements
- **Treelist Control**: At least one `TreeList` control must be used.
- **Database Binding**: All controls should be bound to a SQL Server database.
- **Manual Binding**: Controls cannot be bound using the data wizard; use other methods for data binding.
- **Build**: Ensure that the solution builds correctly without errors.

## Project Description
The application includes a screen that displays room data for a selected building. 

### Features
- **Building Selection**: A combo box allows the user to choose a building.
- **Room Display**: A `TreeList` control updates to show rooms for the selected building.

## Database
- The application uses a SQL Server database. Make sure to restore the provided `.bak` file to your SQL Server instance to set up the database.
