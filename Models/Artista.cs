using Relaciones;

namespace Relaciones.Models;

public class Artista
{
  public int idArtista {get; set;}
  public string Nombre {get; set;}
  public int edad {get; set;}
  public string genero {get;set;}
  public string nacionalidad {get;set;}
  
  public List<Genero> Generos {get;}= new List<Genero>();
  
}
