using UnityEngine;
using System.Collections;
public class Strings : MonoBehaviour {


	private static string[][] gameText ;
	public static string logicaBasica = "porque tiene pulgares oponibles y cerebro desarrollado";
	// Use this for initialization
	void Awake () {

		//ESCENA 1
		gameText = new string[6][];
		gameText [0] = new string[9];
		gameText [0] [0] = "Este es el señor Suzuki";
		gameText [0] [1]="El señor Suzuki es japones";
		gameText [0] [2] = "Los japoneses son seres humanos";
		gameText [0] [3]= logicaBasica;
		gameText [0] [4]="Los humanos hacen cosas buenas";
		gameText [0] [5]="y comen los tomates que cultiva el señor Suzuki";
		gameText [0] [6]="El propio señor Suzuki no los come, solo trabaja 12 horas al dia";
		gameText [0] [7]="para venderlo todo a un supermercado";
		gameText [0] [8]="donde se venden por dinero";


		// ESCENA 2
		gameText [1] = new string[12];
		gameText [1] [0] = "El dinero consiste en pequeñas monedas de metales o billetes de papel";
		gameText [1] [1] = "Existe desde el siglo VII A.C creado por el rey Giges de Libia";
		gameText [1] [2] = "Antes del dinero existia el trueque";
		gameText [1] [3] = "Consiste en cambiar un objeto por otro, ajustando las cantidades";
		gameText [1] [4] = "para poder conseguir un valor equivalente entre los objetos";
		gameText [1] [5] = "Por ejemplo, las gallinas o pollos se cambiaban por ballenas";
		gameText [1] [6] = "Como no era facil ajustar el precio entre dos cosas tan dispares";
		gameText [1] [7] = "Aparecio el dinero";
		gameText [1] [8] = "Aproximadamente desde el siglo III D.C todas las cosas de la tierra";
		gameText [1] [9] = "pueden ser cambiadas por dinero";
		gameText [1] [10] = "sean o no creadas por los seres humanos";
		gameText [1] [11] = "Giges es un personaje del antiguo testamento, libro santo de los judios";

		//ESCENA 3

		gameText [2] = new string[4];

		gameText [2] [0] = "Este es un judio que trabaja para el señor Suzuki";
		gameText [2] [1] = "Cristo era judio.";
		gameText [2] [2] = "Cristo era un ser humano por lo tanto los judios tambien";
		gameText [2] [3] = "porque tienen pulgar oponible y cerebro altamente desarrollado";

		//ESCENA 4

		gameText [3] = new string[20];
		gameText [3] [0] = "Estamos en un supermercado";
		gameText [3] [1] = "Los supermercados son lugares donde se venden alimentos por dinero";
		gameText [3] [2] = "Uno de los tomates cultivados por el señor Suzuki ";
		gameText [3] [3] = "se encuentra en este supermercado ahora";
		gameText [3] [4] = "Esa señora que lo va a comprar";
		gameText [3] [5] = "Es la señora Anete";
		gameText [3] [6] = "La señora Anete es un mamifero bipedo ";
		gameText [3] [7] = "y catolica apostolica romana";
		gameText [3] [8] = "una religion derivada de la judia "; //jd
		gameText [3] [9] = "A su vez es un ser humano";
		gameText [3] [10] = logicaBasica;
		gameText [3] [11] = "Puede comprar ese tomate porque trabaja vendiendo perfumes"; //pf
		gameText [3] [12] = "Los perfumes sirven para hacer oler mejor a los seres humanos";
		gameText [3] [13] = "Y se sacan de las flores";
		gameText [3] [14] = "El lucro que ella obtiene con esta practica estaba prohibido para los cristianos"; //cr
		gameText [3] [15] = "Pero ahora es libre para todos los seres humanos";
		gameText [3] [16] = "Aparte de comprar el tomate compra 2kg de cerdo";
		gameText [3] [17] = "El cerdo es un mamifero pero no tiene pulgares, mucho menos oponibles"; //cd
		gameText [3] [18] = "Por lo tanto, no es un ser humano";
		//ANTES VA ESCENA DE SEÑORA ANETE EN CASA. 

		//ESCENA 5
		gameText [4] = new string[18];
		gameText [4] [0] = "Momentos despues...";
		gameText [4] [1] = "Desgraciadamente, el tomate que se llevo la señora Anete a su casa estaba podrido";
		gameText [4] [2] = "Esto hizo que lo tirara a la basura, considerandolo no apto para el consumo de su familia";
		gameText [4] [3] = "Tirarlo a la basura es una combinacion de esfuerzo entre su cerebro y su pulgar oponible";
		gameText [4] [4] = "La acumulacion de basura puede causar enfermedades"; //lb
		gameText [4] [5] = "Por eso es almacenada en focos lejanos a la poblacion principal";//bs
		gameText [4] [6] = "En Porto Alegre, Brasil; este lugar es conocido como La isla de las flores";
		gameText [4] [7] = "Donde a su vez, existen seres humanos que tienen porciones de tierra en propiedad";//is
		gameText [4] [8] = "Donde dejan almacenar basura y tienen a sus cerdos";
		gameText [4] [9] = "cerdos como los que compro la señora Anete en el supermercado"; //cd
		gameText [4] [10] = "Los cerdos comen todo aquello de la basura de origen organico";
		gameText [4] [11] = "No tienen tanta suerte los otros habitantes de la isla";
		gameText [4] [12] = "Que comen todo producto organico que los cerdos no quieren"; //pobres
		gameText [4] [13] = "Lo que distingue a estos seres humanos, que son humanos";
		gameText [4] [14] = " porque tienen pulgar oponible y cerebro altamente desarrollado"; 
		gameText [4] [15] = "de los cerdos, y por ello tienen menos prioridad a la hora de comer";//lb
		gameText [4] [16] = "es que ellos no tienen ni dueño, ni dinero";
		gameText [4] [17] = "Cuidado con los elementos inorganicos, como el Cesio";






	}
	public static string[] getTextoEscena(int number){
		return gameText[number];
		}
		
			
		
	}
	


