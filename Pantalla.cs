public class Pantalla{
	public int [,] matrizEnteros;
	public Pantalla(var matriz){
		matrizEnteros=matriz;
	}
	public string crear(){
		string resultadoString="";
		for (int i=0; i< matrizEnteros.GetLenght(0);++i){
			for(int j=0;j<matrizEnteros.GetLenght(1);++j){
				resultadoString=" "+ matrizEnteros[i,j].ToString()+ " ";
			}
			resultadoString+="\n";
		}
		return resultadoString;
	}
}