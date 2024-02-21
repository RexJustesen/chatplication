# Chat Application with SignalR
This is a simple chat application built using SignalR, allowing users to join or create chat rooms by providing a username and chat room name. The application does not store any user data, so each time a user leaves, their username is lost and they can use a new username each time they join.

## Features
- Join existing chat rooms.
- Create new chat rooms.
- Send and receive messages in real-time.
- No user data is stored.
## Technologies Used
- SignalR: Used for real-time communication between clients and server.
- React: Frontend framework for building the user interface.
- ASP.NET Core: Backend framework for hosting the SignalR hub and managing chat rooms.
- Bootstrap: CSS framework for styling the user interface.
- Node.js: Runtime environment for running JavaScript on the server side.
- npm: Package manager for managing frontend dependencies.
## Installation
1. Clone the repository:

``git clone https://github.com/RexJustesen/chatplication.git``

2. Navigate to the project directory:

```cd chatplication```

3. Install dependencies for both frontend and backend:


```cd chatplication.app```

```npm install```

```cd ..```

```cd chatplication```

```dotnet restore```

# Usage
1. Start the backend server:


```cd chatplication```

```dotnet run```

2. Start the frontend development server:


```cd chatplication.app```

```npm start```

3. Open your web browser and navigate to http://localhost:3000 to access the application.

# How to Use
1. On the landing page, enter your desired username and the name of the chat room you want to join or create.

2. Click the "Join" button to join an existing chat room or create a new one.

3. Once in the chat room, you can send messages in the chat input field and press "Enter" or click the "Send" button to send the message.

4. You can also leave the chat room or close the application at any time. Your username will be lost when you leave, and you can use a new username each time you join.

# License
This project is licensed under the MIT License - see the LICENSE file for details.

# Acknowledgments
- This project was created to demonstrate the capabilities of SignalR for real-time communication.
- Special thanks to the developers of SignalR, React, ASP.NET Core, and other technologies used in this project.
