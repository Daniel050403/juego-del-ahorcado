using System;
 
public class Ahorcado
{
 
  public static void Main()
  {

   
 
      
 
      string[] palabras = {"juan","daniel","jose"};
      Random generadorAleatorio = new Random();
      int numeroAzar = generadorAleatorio.Next(0,palabras.Length);
      string palabraAdivinar = palabras[ numeroAzar ];
 
      
      string palabraMostrar = "";
      for (int i=0; i< palabraAdivinar.Length; i++)
          if (palabraAdivinar[i] == ' ')
              palabraMostrar += " ";
          else
              palabraMostrar += "-";
 
 
    
      int intentos = 5;
      char letraActual;
      bool terminado = false;
 
      // Parte repetitiva
      do
      {
 
          letra
          Console.WriteLine( "Palabra oculta:  {0}", palabraMostrar);
          Console.WriteLine( "Fallos restantes: {0}", intentos);
 
          
          Console.Write( "Introduzca una letra: ");
          letraActual = Convert.ToChar( Console.ReadLine() );
 
          
          if( palabraAdivinar.IndexOf( letraActual ) == -1 )
              intentos--;
 
        
          string siguienteMostrar = "";
 
          for( int i = 0; i < palabraAdivinar.Length; i++)
          {
              if( letraActual == palabraAdivinar[i] )
                  siguienteMostrar += letraActual;
              else
                  siguienteMostrar += palabraMostrar[i];
          }
          palabraMostrar = siguienteMostrar;
 
          /
          
          if( palabraMostrar.IndexOf("-") < 1 )
          {
              Console.WriteLine("Felicidades, acertaste!  ({0})",
                 palabraAdivinar);
              terminado = true;
          }
 
          if( intentos == 0 )
          {
              Console.WriteLine("Lo siento. Era {0}", palabraAdivinar);
              terminado = true;
          }
 
          Console.WriteLine();
      }
      while ( ! terminado );
 
  }
}
