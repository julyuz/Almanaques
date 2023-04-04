
var a;
let b;
const c = "c";

"Buscar elemento en Arreglo"
const names = [
      {"id": 1, "nom": "Ana"},
      {"id": 2, "nom": "Pablo"},
      {"id": 3, "nom": "Pedro"},
      {"id": 4, "nom": "Pancracio"}
];

function checkName(name) {
	return name.nom == 'Pancracio';
}
document.getElementById("demo1").innerHTML = names.find(checkName).nom;

const ultNam_5pos = names.findLast((name) => name.length == 5);       // 'Pedro'
names.findLastIndex((name) => name.length == 5);  // 2

document.getElementById("demo").innerHTML = "arrayNames, ultNam_5pos: " + ultNam_5pos;

"Condiciones para una clase"
{/* <tr v-for="(item,index) in tabla" :key="index" style="font-size:12px" @dblclick="getDatosIp(item.di_id)" 
      :class="[
      ( (item.di_disp == 'DESKTOP' || item.di_disp == 'MINIBRIX' || item.di_disp == 'LAPTOP') 
            && item.fec_prox_man == '' ? 'fila_amarillo' : '' ),

      ( (item.di_disp == 'DESKTOP' || item.di_disp == 'MINIBRIX' || item.di_disp == 'LAPTOP')
            && item.fec_prox_man != '' && item.fec_prox_man < item.fecha_actual ? 'fila_rojo' : 'fila_verde'),

      (item.di_disp != 'DESKTOP' && item.di_disp != 'MINIBRIX' && item.di_disp != 'LAPTOP') ? 'fila_azul_bajo' : ''
      ]"
> */}

"Función para filtrar por datos de una columna en una tabla"
function myFunction() {
      var input, filter, table, tr, td, i, txtValue;
      input = document.getElementById("input_buscar");
      filter = input.value.toUpperCase();

      console.log("filter: " + filter);

      table = document.getElementById("dev-table");
      tr = table.getElementsByTagName("tr");

      for (i = 0; i < tr.length; i++) {
          td = tr[i].getElementsByTagName("td")[4];
          
          if (td) {
              txtValue = td.textContent || td.innerText;
              if (txtValue.toUpperCase().indexOf(filter) > -1) {
                  tr[i].style.display = "";
              } else {
                  tr[i].style.display = "none";
              }
          }
      }
  }

"Alerta 'SweetAlert' "
Swal.fire({
    position: 'center',
    icon: 'success',
    title: '¡Se realizó correctamente!',
    showConfirmButton: false,
    timer: 1500
});

"Validar variable vacía"
if (vm.equipo.di_ip == '' || typeof vm.equipo.di_ip === 'undefined') {
    console.log("vacía o undefined");
}

"Foco en un input (JQuery)"
function setInputFocus() {
    $('#input_buscar').focus();
}

"JQUERY - Activar detección de errores para todas las llamadas ajax de la pagina"
$.ajaxSetup({
    error: function( jqXHR, textStatus, errorThrown ) {
    // .done( function() {
            // alert( 'Success!!' );
    // }).fail( function( jqXHR, textStatus, errorThrown ) {

        // alert( 'Error!!' );

        if (jqXHR.status === 0) {
            console.log('Not connect: Verify Network.');
        } else if (jqXHR.status == 404) {
            console.log('Requested page not found [404]');
        } else if (jqXHR.status == 500) {
            console.log('Internal Server Error [500].');
        } else if (textStatus === 'parsererror') {
            console.log('Requested JSON parse failed.');
        } else if (textStatus === 'timeout') {
            console.log('Time out error.');
        }
        // }).always( function() {
        //     alert( 'Always' );
    }
});

"Metodo push()"
// El método .push() nos permite agregar uno o más elementos al final de un array. A continuación veremos un ejemplo aplicado con un array que contiene números:
let numArray = [1, 2, 3, 4, 5];

function newNum() {
    numArray.push(6, 7);
}

"Metodo shift()"
// Si necesitamos eliminar un elemento del array. .shift() elimina el primer elemento de un array, es decir, elimina el elemento que esté en el índice 0.
let shiftArray = numArray.shift();

// El método .pop() eliminará el último elemento de un array. En este sentido, si tenemos un array de 5 elementos, pop() eliminará el elemento en el índice 4. Utilicemos el mismo ejemplo pero usando este método.
shiftArray = numArray.pop();

"Resumen: " +
"Agregar al final= .push() " +
"Eliminar al final= .pop() " +

"Agregar al inicio= .unshift() " +
"Eliminar al inicio= .shift()"

"Metodo splice()"
var articulos = ['carro', 'celular', 'moto', 'tv', 'libro']; //eliminar moto

articulos.splice(2, 1); //el primer parámetro especifica el índice del elemento que quiero eliminar, en este caso es moto
//y el segundo parámetro especifica cuantos elementos del arreglo quiero eliminar, en este caso solo uno que es moto
//['carro', 'celular', 'tv', 'libro']

"Metodo splice()"
var articulos = ['carro', 'celular', 'moto', 'tv', 'libro']; //modificar moto

articulos.splice(2, 1, 'laptop'); /*se aplican los mismo parámetros, pero esta vez se le agrega el valor al que queremos modificar*/
//['carro', 'celular', 'laptop', 'tv', 'libro']

"Metodo filter()"
let articulos = [
    { nombre : "Bici", costo : 3000 },
    { nombre : "TV", costo : 2500 },
    { nombre : "Libro", costo : 320 },
    { nombre : "Celular", costo : 10000 },
    { nombre : "Laptop", costo : 20000 },
    { nombre : "Teclado", costo : 500 },
    { nombre : "Audifonos", costo : 1700 },
];

// Retorna un nuevo array con los articulos que coincidan con lo indicado
let articulosFiltrados = articulos.filter((articulo) => {
    return articulo.costo <= 500
});

// Retorna un nuevo array con los nombres de los articulos
"Metodo map()"
let nombreArticulos = articulos.map((articulo) => {
    return articulo.nombre
});

// Retorna un nuevo array con la 1era coincidencia de lo indicado (no recorre todo el array sólo hasta la 1era coincidencia)
"Metodo find()"
let encuentraArticulo = articulos.find((articulo) => {
    return articulo.nombre === "Laptop"
});

// No genera un nuevo array, solo recorre el array
"Metodo forEach()"
articulos.forEach((articulo) => {
    console.log(articulo.nombre);
});

// Retorna True o False si se existen valores que cumplan la condición
"Metodo some()"
let articulosBaratos = articulos.some((articulo) => {
    return articulo.costo <= 700
});










//_____VALORES_____
//40 numero

//"texto" Texto o string

//true boleano
//false boleano

//null valores vacios
//undefined valores vacios

//[1,2,3,4]valores primitivos dentro de un array "Esto es tipo objeto"

//{nombre: "daniel"} Valor tipo objeto

var nombre = "Oscar";
// declarar 
var edad;
// inicializar
edad = 30;
var elementos = ["Computadora, Celular"]
var persona = {
    nombre: "Daniel",
    edad: 30
}
persona



//____FUNCIONES_____

// Funciones Declararivas
function miFuncion(c,d) {
    return c + d;
}
miFuncion ();

// Funciones de Expresión
var mifuncion = function (a,b){
    return a + b;
}
mifuncion ();

//_____HOISTING_____
console.log(miNombre)
var miNombre = "Daniel";
hey ();
function hey() {
    console.log("hola "miNombre)
}



//______COHERCION_______
//Cohercion inplicita
var a = 4 + "7";
a
// a es un string
var b = 3 * "4";
b
// b es tipo numero7

//cohercion explicita
d = 34;
var e = String(d);
// d es un numero y e es un string con el calor de d
f= "45";
var g = Number(f);
// f es un valor String y g es tiene el valor de f pero es un tipo Número



//_______TRUTHY & FALSY______
// FALSE___FALSE
Boolean (0);
//false
Boolean (null);
//false
Boolean (NaN);
//false
Boolean (undefined);
//false
Boolean (false);
//false
Boolean ("");
//false

// TRUE ____TRUE
Boolean (" ");
//true
Boolean ("a");
//true
Boolean (1);
//true
Boolean ([]);
//true
Boolean ({});
//true
Boolean (function());
//true
Boolean (true);
//true



//_______OPERADORES__________
// Operadores Matematicos
3 + 2
//5
25 - 10
//15
10 * 3
//30
15 / 3
//5
"Daniel" + "Valdivieso"
//Daniel Valdivieso

! //negación
!false
//true
= //asignacion var a = 1
== //comparación 3 == "3" ?
=== // 3 === "3" falso porque uno es string y otro es numero por lo tanto no son exactamente iguales

5 < 3 //false
5 > 3 //True
5 <= 6 //true
5 >= 6 //false
a && b // si a es T y b es T entonces es True, si alguna es falsa entonces el condicional es falso
!= //diferente 
a || b // si a es T o b es T entonces la condicion es T.
var edad = 40
edad ++ // es la variable + 1 
edad += 2 // es variable + 2


//______ CONDICIONALES_________
// ____if___
if () {
}
else if () {
}
//si no se cumplio el if se evalua el () del else if
else {
}
//lo que este dentro de () tiene que ser verdad "valida booleans" para que pase lo que esta en {}
// si lo que esta dentro de () es falso, entonces ejecutara el else{}
condition ? true : false; //condicional ternario
var numero = 1;
var resultado = numero === 1 ? "Sí, soy un 1" : "No, no soy 1"

//____SWITCH______
var numero = 1;
switch (true){
    case 1:
        console.log("Soy uno!");
    break;
    caso 10:
    console.log("Soy un 10!")
    break;
    caso 50:
    console.log("Si, soy un 50")
    break;
    default:
        console.log("No soy nada")
}



//__________ARRAYS_________
var frutas = ["manzana", "plátano", "cereza", "fresa"];
console.log(frutas.length) //imprime el numero de elementos del array

var masFrutas = frutas.push ("uvas") // añade uvas al final del array anterior

var ultimo = frutas.pop ("uvas"); // elimina el ultimo elemento del array 

var nuevaLongitud = frutas.unshift("uvas"); //añade elementos al inicio del array

var borrarFruta = frutas.shift("uvas"); // elimina el primer elemento del array

var polisicion =frutas.indexOf ("cereza"); //busca la posicion del elemento dentro del array



//___________LOOPS FOR & FOR...OF__________
var estudiantes = ["Maria","Sergio", "Rosa", "Daniel"];

function saludarEstudiantes(estudiante) {
    console.log (`Hola, ${estudiante}`);
}
for (var i = 0; i < estudiantes.length; i++){
    saludarEstudiantes(estudiantes[i]);
}

var estudiantes = ["Maria","Sergio", "Rosa", "Daniel"];

function saludarEstudiantes(estudiante) {
    console.log (`Hola, ${estudiante}`);
}
for (var estudiante of estudiantes){
    saludarEstudiantes(estudiante);
}



//__________LOOPS WHILE___________
var estudiantes = ["Maria", "Sergio", "Rosa", "Daniel"]
function saludarEstudiantes(estudiante){
    console.log(`Hola, ${estudiante}`);
}
while(estudiantes.length > 0){
    console.log(estudiantes)
    var estudiante = estudiantes.shift();
    saludarEstudiantes(estudiante)
}



//______________OBJECTS______________
var miAuto = {
    marca: "Toyota",
    modelo: "Corolla",
    annio: 2020,
    detalleDelAuto: function(){
        console.log (`Auto ${this.modelo} ${this.annio}`)// this hace referencia a su padre que en este caso es miAuto, en la escritura no existe diferencia
    }
};

miAuto //imprime los objetos y sus valores

miAuto.marca //imprime el valor del objeto
miAuto.annio //imprime el valor del objeto
miAuto.detalleDelAuto() //imprime los valores del objeto

//_______FUNCION CONSTRUCTORA________

function auto(marca, modelo, annio){
    this.marca = marca;
    this.modelo =modelo;
    this.annio = annio;
}

auto //imprime todo el objeto

var autoNuevo = new auto("Tesla", "Model 3", "2020");
autoNuevo //imprime los valores del objeto
var autoNuevo2 = new auto("Tesla", "Model X", 2018);
var AutoNuevo3 = new auto("Toyota", "Corolla", 2020);

autoNuevo2 //imprime los valores del objeto



//__________METODOS DE RECORRIDOS DE ARRAYS_________
var articulos = [
    {nombre:"Bici", costo: "3000"},
    {nombre:"Tv", costo:"2500"},
    {nombre:"Libro", costo:"320"},
    {nombre:"Celular", costo:"10000"},
    {nombre:"Laptop", costo:"20000"},
    {nombre:"Teclado", costo:"500"},
    {nombre:"Audifonos", costo:"1700"},
];

//________MEDOTO 1__________FILTRA ELEMENTOS ESPECIALMENTE
var articulosFiltrados = articulos.filter(function(articulo){
    return articulo.costo <=500
});
articulosFiltrados //imprime los valores menores o iguales a 500

//_________METODO 2___________MAPEA LOS ELEMENTOS DE
var nombreArticulos = articulos.map (function(srticulo){
    return articulo.nombre
});
nombreArticulos // imprime los nombres de los articulos del objeto

//________METODO 3_________ BUSCA ALGO DENTRO DEL ARTICULO
var encuentraArticulo = articulos.find(function(articulo){
    return articulo.nombre === "Laptop"
});
encuentraArticulos //imprime los elementos y valores del elemento buscado.

//________METODO 4_________ 
articulos.forEach(function(articulo){
    console.log(articulo.nombre) //imprime el valor del elemento especificado solamente
});

//_________METODO 5_________
var articulosBaratos = articulos.some(function(articulo){
    return articulo.costo <=700;
});
articulosBaratos //imprime un boleano que afirma si la consicion es verdadera o falsa



//__________AÑADIR Y ELIMINAR ELEMENTOS DE UN ARRAY_________
//Añadir elementos (Numeros) a un Array
//__________ .push() __________

let numArray = [1,2,3,4,5]

//Función
function newNum(){
    //Agrego elementos
    numArray.push(6,7)
    console.log(numArray)//imprime los elementos viejos y los nuevos
}
newNum ()//ejecuto la función para permitir al console.log imprimir los elementos

//Añadir elementos "strings" a un Array
Let txtArray = ["Ana", "Juan", "Diego", "Laura"] //Definición del array
function addCharacters(){
    txtArray.push("Chris", "María")
    console.log(txtArray)//Imprime los elementos viejos y los nuevos
}
addCharacters () //Ejecuta la funcion para ejecutar el console.log

//__________ .shift ____________ ELIMINA PRIMER ELEMENTO

let array = [1,2,3,4,5]
console.log(array) //imprime el array existente

let shiftArray = array.shift() //Se aplica la eliminacion del primer elemento del array

console.log(array)//imprime el nuevo array con el primer elemento borrado

//____________ .pop ______________ ELIMINA EL ULTIMO ELEMENTO

let array = [1,2,3,4,5]
console.log(array) //imprime el array existente

let shiftArray = array.pop() //Se aplica la eliminacion del ultimo elemento del array

console.log(array)//imprime el nuevo array con el primer elemento borrado
