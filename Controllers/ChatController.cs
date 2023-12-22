using Microsoft.AspNetCore.Mvc;
using OpenAI_API;
using OpenAI_API.Chat;
using OpenAI_API.Images;

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
    public async Task<IActionResult> SendMessage([FromBody] ChatRequest request)
    {
        var chat = _openAIApi.Chat.CreateConversation();
        chat.AppendSystemMessage("You are a witty and knowledgeable assistant. You have a slight sense of humor.");
        chat.AppendUserInput(request.UserMessage);

        var response = await chat.GetResponseFromChatbotAsync();
        return Ok(new { message = response });
    }
    [HttpPost("generateImage")]
    public async Task<IActionResult> GenerateImage([FromBody] ImageRequest request)
    {
        var result = await _openAIApi.ImageGenerations.CreateImageAsync(new ImageGenerationRequest(request.Prompt, OpenAI_API.Models.Model.DALLE3, ImageSize._1024x1792, "hd"));

        if (result?.Data != null && result.Data.Count > 0)
        {
            return Ok(new { imageUrl = result.Data[0].Url });
        }
        return BadRequest("Image generation failed");
    }

}

public class ChatRequest
{
    public string UserMessage { get; set; }
}
public class ImageRequest
{
    public string Prompt { get; set; }
}