# ConvoCraft - AI English Tutor (ASP.NET Core MVC)


ConvoCraft is a web application that acts as your personal AI English Tutor. It provides a simple and engaging chat interface where users can practice their English conversation skills with a helpful AI. The AI is designed to be a friendly and encouraging partner, offering polite corrections and keeping the conversation flowing.

This project is a C# / ASP.NET Core MVC conversion.

## ✨ Features

* **Interactive Chat Interface**: A clean, real-time chat window to converse with the AI.
* **AI-Powered Conversation Partner**: Powered by an external LLM, the AI is prompted to act as a "helpful English tutor".
* **Polite Grammar and Vocabulary Correction**: The AI is instructed to "Correct any grammar or vocabulary mistakes politely".
* **Text-to-Speech**: AI responses are spoken aloud to help with listening and pronunciation.

## 🛠️ Tech Stack

* **Backend**: C#, ASP.NET Core MVC
* **Frontend**: HTML, CSS, JavaScript

## 🚀 Getting Started

To get a local copy up and running, follow these simple steps.

### Prerequisites

* .NET 8 SDK or later.
* A code editor like Visual Studio or VS Code.

## ⚙️ API Configuration

The application communicates with an external AI service to generate responses.

* **API Endpoint**: The URL is configured within `Controllers/ChatController.cs`.

## 📁 Project Structure

The project follows a standard ASP.NET Core MVC structure.

```
/
├── Controllers/
│   └── ChatController.cs   # Handles incoming requests, calls the AI API, and returns responses.
├── Models/
│   ├── ChatMessage.cs      # Represents a single chat message.
│   ├── ConversationPayload.cs # DTO for data sent from the client.
│   └── ...                 # Other models for API requests/responses.
├── Views/
│   └── Chat/
│       └── Index.cshtml    # The main Razor view containing the HTML structure and client-side JavaScript.
├── wwwroot/
│   ├── css/                # For stylesheets.
│   └── js/                 # For external JavaScript files.
└── Program.cs              # Application entry point and service configuration.
```
