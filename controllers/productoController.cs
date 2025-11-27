using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using backend.Data;
using backend.models;

namespace ApiProductos.Controllers;

[Route("api/products")]
[ApiController]
public class ProductoController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public ProductoController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Products>>> Get()
    {
        return await _context.Productos.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Products>> GetProductoById(int id)
    {
        var producto = await _context.Productos.FindAsync(id);

        if (producto == null)
            return NotFound(new { mensaje = "Producto no encontrado" });

        return Ok(producto);
    }


    [HttpPost]
    public async Task<ActionResult<Products>> CrearProducto(Products producto)
    {
        try
        {
            _context.Productos.Add(producto);
            await _context.SaveChangesAsync();

            return Ok(new
            {
                mensaje = "Producto guardado correctamente",
                producto = producto
            });
        }
        catch (Exception ex)
        {
            return BadRequest(new { mensaje = "Error al guardar", error = ex.Message });
        }
    }

    [HttpPut("{id}")]
        public async Task<IActionResult> PutProducto(int id, [FromBody] Products productoActualizado)
        {
            if (id != productoActualizado.id)
            {
                return BadRequest("El ID no coincide.");
            }

            var producto = await _context.Productos.FindAsync(id);
            if (producto == null)
            {
                return NotFound("Producto no encontrado.");
            }

            // Actualizar campos
            producto.nombre = productoActualizado.nombre;
            producto.precio = productoActualizado.precio;
            producto.stock = productoActualizado.stock;
            producto.categoria = productoActualizado.categoria;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                return StatusCode(500, "Error al actualizar el producto.");
            }

            return Ok(producto);
        }

   
    
}
