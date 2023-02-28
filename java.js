const aplicacion = document.querySelector('.container')

const cargaDatos = async () => {

    try {
        const repuesta = await fetch('https://randomuser.me/api/?gender=male');
        //console.log(repuesta);

       const objPersona = await repuesta.json();
       //console.log(objPersona);
       
       document.getElementById('imagenApi').src= objPersona.results[0].picture.large;       //imagen

       document.getElementById('nomApellido').innerHTML=objPersona.results[0].name.first + " " +objPersona.results[0].name.last; //Nombre y Apellido

       //Domicilio,altura,ciudad,pais.
       document.getElementById('domicilio').innerHTML=objPersona.results[0].location.street.name + " N° "+objPersona.results[0].location.street.number+", "+ objPersona.results[0].location.postcode+", "+objPersona.results[0].location.city + ", "+objPersona.results[0].location.country;

       document.getElementById('edad').innerHTML=objPersona.results[0].dob.age;

       document.getElementById('correo').innerHTML=objPersona.results[0].email;

       document.getElementById('telefono').innerHTML=objPersona.results[0].cell;
        
       document.getElementById('nacionalidad').innerHTML=objPersona.results[0].nat;


    }catch(error){
        console.log(error);
    }
    

}

cargaDatos();

//Botones configuracion 
//Reemplazar texto y cambiar color
document.getElementById('mostrarTexto').onclick = function(){
    document.getElementById("datosPersonal").innerHTML ="Puedes usar esta pantilla como referencia!";
    document.getElementById("datosPersonal").style.webkitTextFillColor="blue";
}

//Cambiar foto
document.getElementById('cambiarFoto').onclick = function(){
document.getElementById("imagenApi").src='imagen/migue.jpg';
image.width ='2px';
image.height ='2px';
}
//Cambiar color de texto
document.getElementById('cambiarColorTexto').onclick = function(){
    document.getElementById("bodyColorTExto").style.webkitTextFillColor='red';
}
document.getElementById('cambiarTemaColor').onclick = function(){
    document.getElementById('headerColor').style.background= 'Lightblue';
    document.getElementById('cajaLaboral').style.background= 'Lightblue';
    document.getElementById('cajaInformacion').style.background= 'Lightblue';
    document.getElementById('footer').style.background= 'Lightblue';
}