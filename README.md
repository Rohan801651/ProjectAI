# ConvoCraft - AI English Tutor (ASP.NET Core MVC)

![License: 0BSD](https://img.shields.io/badge/License-0BSD-blue.svg)

ConvoCraft is a web application that acts as your personal AI English Tutor. It provides a simple and engaging chat interface where users can practice their English conversation skills with a helpful AI. The AI is designed to be a friendly and encouraging partner, offering polite corrections and keeping the conversation flowing.

This project is a C# / ASP.NET Core MVC conversion of an original React Native application.

## ✨ Features

* **Interactive Chat Interface**: A clean, real-time chat window to converse with the AI.
* **AI-Powered Conversation Partner**: Powered by an external LLM, the AI is prompted to act as a "helpful English tutor".
* **Polite Grammar and Vocabulary Correction**: The AI is instructed to "Correct any grammar or vocabulary mistakes politely".
* **Text-to-Speech**: AI responses are spoken aloud to help with listening and pronunciation, using `expo-speech` on native and the browser's `SpeechSynthesis` on the web.
* **Voice-to-Text Input**: Use your microphone for input, leveraging the browser's built-in `SpeechRecognition` API.

## 🛠️ Tech Stack

* **Backend**: C#, ASP.NET Core MVC
* **Frontend**: HTML, CSS, JavaScript
* **Real-time Communication**: Client-side JavaScript using `fetch` for AJAX calls to the ASP.NET controller.
* **Speech APIs**: Browser-native `SpeechSynthesis` and `SpeechRecognition`.

## 🚀 Getting Started

To get a local copy up and running, follow these simple steps.

### Prerequisites

* .NET 8 SDK or later.
* A code editor like Visual Studio or VS Code.

### Installation & Running

1.  **Clone the repository:**
    ```sh
    git clone [https://github.com/your-username/ConvoCraft-ASPNET.git](https://github.com/your-username/ConvoCraft-ASPNET.git)
    ```
2.  **Navigate to the project directory:**
    ```sh
    cd ConvoCraft-ASPNET
    ```
3.  **Restore .NET dependencies:**
    ```sh
    dotnet restore
    ```
4.  **Run the application using the `start` script**:
    ```sh
    dotnet run
    ```
5.  **Open your browser** and navigate to the local URL provided in the terminal (e.g., `https://localhost:7123` or `http://localhost:5123`).

## ⚙️ API Configuration

The application communicates with an external AI service to generate responses.

* **API Endpoint**: The URL `https://api.a0.dev/ai/llm` is configured within `Controllers/ChatController.cs`.
* **Authentication**: The current implementation does not include an API key. If the external API requires authentication, you must modify the `HttpClient` request in `ChatController.cs` to include the necessary `Authorization` header.

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
