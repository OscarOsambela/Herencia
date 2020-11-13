using System;

class MainClass {
  public static void Main (string[] args) {
   //objetivo principal de la herencia es reutilizar codigo de programacion y no tener que programar lo mismo  
		//4.instanciar a clase 
    Acciones botones = new Acciones();
    botones.agregar();

    //5.instanciar la clase
    Botones botones_ = new Botones();
    botones_.eliminar();
    botones_.agregar();
  }
  //1.crear la clase
	class Acciones{
    //2.crear metodos
		public void agregar()=> Console.WriteLine("Agregar item");
		
		public void eliminar()=> Console.WriteLine("Eliminar item");
	}
  //3.crear nueva clase y declarar la herencia de la primera clase
  class Botones:Acciones{
    //la clase botones esta tomando heredadandp los metodos de la clase Acciones 
    public void boton1()=> Console.WriteLine("boton numero uno");
    public void boton2()=> Console.WriteLine("boton numero dos");
  }
}