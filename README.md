# MunServices - Maswanganye, K.A.J.
# Mun Services - Municipal Service Request Management System

## Overview
Mun Services is a comprehensive Windows Forms application designed to manage municipal service requests, local events, and announcements. The system utilizes advanced data structures and algorithms to provide efficient service request tracking and management capabilities.

## Features

### Service Request Management
- Three-stage Kanban board (To Do, In Progress, Done) for request tracking
- Status-based organization with automatic updates
- Location-based clustering of related issues
- Multi-level filtering and flexible sorting options
- File attachment support for service requests

### Data Structures Implementation
- **Binary Search Tree (BST)**: For basic service request storage and retrieval
- **AVL Tree**: Self-balancing tree for maintaining sorted views
- **Red-Black Tree**: Ensures efficient operations with frequent updates
- **Heap**: Priority-based queue system for service request handling
- **Graph**: For managing relationships between service requests
- **Minimum Spanning Tree (MST)**: Optimizes service routes using Kruskal's algorithm

### Performance Features
- O(log n) time complexity for most operations
- Efficient data retrieval through multiple access paths
- Automatic data structure updates and synchronization
- Robust error handling and data validation

## Getting Started

### Prerequisites
- .NET Core SDK
- Visual Studio (recommended) or preferred IDE
- Windows operating system

### Installation
1. Clone the repository
2. Open the MunServices solution in Visual Studio
3. Build the solution to ensure all projects compile successfully
4. Run the MunServices project

### Usage

#### Reporting Issues
1. Launch the application
2. Click "ReportIssuesForm" button
3. Fill in required details (location, category, description)
4. Attach relevant files if needed
5. Submit the service request

#### Managing Service Requests
1. Navigate to ServiceRequestStatusForm
2. View requests in To Do, In Progress, and Done sections
3. Use search and filter options to find specific requests
4. Double-click requests to update their status
5. View related issues and optimal service routes

## Technical Architecture

### Data Persistence
- JSON file storage for service requests and related data
- Robust file handling and serialization
- Data integrity maintenance across operations

### Performance Optimization
- Efficient data structure implementations
- Balanced tree structures for consistent performance
- Location-based clustering for quick access
- Priority-based organization using heap structure

## Future Enhancements
- MongoDB integration for improved scalability
- Redis Cache implementation for faster data retrieval
- ASP.NET Core Web API backend
- Real-time updates using SignalR
- Power BI integration for advanced analytics
- Cross-platform mobile access via Xamarin
- Azure Cloud Services deployment
- Comprehensive testing with xUnit and Moq

## Contributing
Contributions are welcome. Please feel free to submit a Pull Request.

## License
This project is licensed under the MIT License - see the LICENSE.md file for details

## Acknowledgments
- Programming 3B Module
- Module Code: PROG7312
- Lecturer: Moses Olaifa
