# Final Expense Tracker

A C# Windows Forms application for tracking personal income and expenses.

## Features

- Add expenses
- Add income
- Create expense categories
- Create income categories
- Track expense information
- Filter expense data
- Display expense data
- Visualize financial data using a pie chart
- Set expense category budgets
- Customize currency symbol

## Technologies

- C#
- .NET Framework 4.8
- Windows Forms
- Visual Studio

## Project Structure

The application is divided into several Windows Forms UserControls:

- `AddExpenseUc` – Add expenses
- `AddCategoryUc` – Manage categories
- `ExpenseTrackerUc` – Main expense tracking functionality
- `DataViewUc` – Display financial data
- `FilterUc` – Filter expense data
- `PIeChartUc` – Visualize financial information
- `DataManager` – Manage application data

## Requirements

- Windows
- Visual Studio
- .NET Framework 4.8

## How to Run

1. Clone this repository.
2. Open `FinalExpenseTracker.sln` in Visual Studio.
3. Build the solution.
4. Run the application.

## Notes

The application currently stores expense and income data in memory during runtime.
