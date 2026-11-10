# Hotel Management System

A desktop hotel booking application developed in **C# and Windows Forms** as an early programming project. It demonstrates basic form-based user interaction, simple booking workflows, and file-based data storage.

> **Learning project:** This application uses a plain-text file (`BookingData.txt`) to simulate persistent booking records. It does **not** use SQL or a relational database, and is not intended for production use.

## Features

- **Guest booking form:** Enter guest name, surname, age, phone number, stay dates, number of guests, and room type (single or double).
- **Booking reference:** Generate a random booking number and record the booking timestamp.
- **Local data storage:** Append booking records to a pipe-delimited text file.
- **Management view:** Load stored bookings into a Windows Forms table (`DataGridView`).
- **Demo administrator access:** Open the management interface through a login form with preset demonstration credentials.

## Tech stack

- C#
- .NET 5 (Windows desktop target)
- Windows Forms
- Plain-text file storage (`System.IO`)

## Running the project

1. Use **Windows** and install **Visual Studio** with the *.NET desktop development* workload.
2. Open `HotelManagement.sln`.
3. Restore dependencies and build/run the `HotelManagement` project.
4. Create a booking through the booking interface. The application will create `BookingData.txt` in its working directory.
5. Use the management interface to view saved bookings.

### Demo administrator credentials

| Field | Value |
| --- | --- |
| Username | `admin` |
| Password | `Hoteldemo` |

These credentials are intentionally hardcoded for demonstration purposes. **Do not reuse this login approach in a production application.**

## Data storage

Bookings are written as text records with `|` separators and then read back into a table. This is a simplified file-based approach created before learning SQL/database integration. It does not provide database features such as relational constraints, transactional updates, or secure multi-user storage.

The `BookingData.txt` file is excluded from Git to avoid publishing guest names and phone numbers.

## Screenshots

Screenshots of the booking form and management interface can be added here in a future update.

## Project context and limitations

This is a learning/portfolio project rather than a production-ready booking system. Validation is limited, booking identifiers are randomly generated, and administrator authentication is for demo use only. The project currently targets .NET 5, an older version of .NET.
