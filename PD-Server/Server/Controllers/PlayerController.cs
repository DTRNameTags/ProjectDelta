using Microsoft.AspNetCore.Mvc;
using SharedLibrary;

namespace Server.Controllers;

[ApiController]
[Route("[controller]")]
public class PlayerController : ControllerBase {

    [HttpGet]
    public Player Get([FromQuery] int id) {
        var player = new Player();

        return player;
    }

    [HttpPost]
    public Player Post(Player player) {
        Console.WriteLine("Player Has Been Added To The Database");

        return player;
    }

}