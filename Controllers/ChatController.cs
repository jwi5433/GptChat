using Microsoft.AspNetCore.Mvc;
using OpenAI_API;
using OpenAI_API.Chat;

[ApiController]
[Route("[controller]")]
public class ChatController : ControllerBase
{
    private readonly OpenAIAPI _openAIApi;

    public ChatController(IConfiguration configuration)
    {
        var apiKey = configuration["CHATGPT_API_KEY"];
        _openAIApi = new OpenAIAPI(apiKey);
    }

    [HttpPost("message")]
    public async Task<IActionResult> SendMessage([FromBody] string userMessage)
    {
        var chat = _openAIApi.Chat.CreateConversation();
        chat.AppendSystemMessage("You are a witty and knowledgeable assistant. You have a slight sense of humor.");
        chat.AppendUserInput(userMessage);

        var response = await chat.GetResponseFromChatbotAsync();
        return Ok(new { message = response });
    }
}