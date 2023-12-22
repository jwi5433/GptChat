# OpenAI Chat Application
This project is a chat application that uses OpenAI's GPT-3.5 Turbo and DALL-E models to respond to user messages and generate images. The backend is built with ASP.NET, and the frontend is a React application.

## Prerequisites
Before you begin, ensure you have met the following requirements:

- [.NET 6.0 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- [Node.js](https://nodejs.org/)
- An IDE like [Visual Studio](https://visualstudio.microsoft.com/) or [VS Code](https://code.visualstudio.com/)
- [Git](https://git-scm.com/downloads) for cloning the repository

```bash
git clone [https://github.com/jwi5433/GptChat.git]
```
## Setting Up the Environment
Obtain an API Key from OpenAI:

Sign up or log in to your OpenAI account and obtain an API key from the OpenAI API Dashboard.

## Configure the API Key in ASP.NET:

- Set the OpenAI API key as an environment variable named CHATGPT_API_KEY.
- In Windows, this can be done in the System Properties -> Environment Variables, or directly in your IDE if it supports environment variable configuration.

## Running the Backend
Navigate to the Backend Directory:

Assuming you're in the root directory of the cloned repository:

```bash
cd gpt
```
## Build and Run the ASP.NET Application:

```bash
dotnet build
dotnet run
```

## Verify:

- The backend should be running on http://localhost:5168.
Running the Frontend

## Navigate to the Frontend Directory:

```bash
cd gpt-front
```

## Install Dependencies:

```bash
npm install
```

## Start the React App:

```bash
npm start
```

## Access the Application:

The frontend should be accessible at http://localhost:3000.

## Using the Application

To chat, type your message and click Send.
To generate an image, type "generate image: " followed by the description of the image, e.g., generate image: a dog riding a bike.
