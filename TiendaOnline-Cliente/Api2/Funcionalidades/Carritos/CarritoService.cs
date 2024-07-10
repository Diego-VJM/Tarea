
using Aplicacion.Dominio;

namespace Api.Funcionalidades.Carritos;

public interface ICarritoService
{
    List<Carrito> GetCarritos();

}
public class CarritoService : ICarritoService
{
    public List<Carrito> GetCarritos()
    {
        return new List<Carrito>();
    }   
}