using Microsoft.AspNetCore.Mvc;
using TGE.Services.

namespace TGI.WebApi.Controllers;

[Route("api/[controller]")]
public class LikesController : ControllerBase
{
    private readonly  _context;

    public LikesController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<IActionResult> PostLike([FromBody] Like like)
    {
        _context.Likes.Add(like);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetLike", new { id = like.LikeId }, like);
    }

    [HttpGet("post/{postId}")]
    public async Task<IActionResult> GetLikesByPostId([FromRoute] int postId)
    {
        return await _context.Likes.Where(l => l.PostId == postId).ToListAsync();
    }
}