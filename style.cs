body {

    background-color: red ;
    font-family: 'Montserrat', sans-serif;

}

header {
    background-color: pink;
    padding: 30px 0;
}

.caja {
    width: 940px;
    position: relative;
    margin: 0 auto;
}

.logo {
    float: left;
}

.titulo {
    display: inline;
    margin-left: 130px;
}

nav {
    position: absolute;
    top: 25px;
    /**Posicion de las anclas*/
    right: 0;
    /*background-color: blue;*/
}

nav li {
    display: inline;
    margin: 0 0 0 15px;
}

nav a {
    text-transform: uppercase;
    color: #000000;
    font-weight: bold;
    font-size: 20px;
    text-decoration: none;

}

nav a:hover {
    color: hwb(300 17% 31%);
    text-decoration: underline;

}

#linKedinlogo,
#ghitHubIcono,
#homeIcono {
    font-size: 20px;
    align-self: center;
}


main {
    width: 940px;
    height: 940px;
    position: relative;
    margin: 0 auto;
    background-color: rgb(245, 240, 237);
}

.cajamain {
    width: 940px;
    height: auto;
    margin: 0px auto;


}

.ladoIzq {
    float: left;
    width: 20%;
}



.imagenApi {
    width: 5px;
    height: 5px%;
    margin-top: 5px;
    margin-right: 5px;
    border-radius: 15px;
    transition: 400ms;
    border: 2px solid black;
    /**box-shadow: 5px 8px 40px 10px rgb(11, 26, 235);*/
}

.imagenApi:hover {
    opacity: 0.4;
}

.botones {
    width: 100%;
    height: auto;
    border: 2px solid #000000;
    border-radius: 15px;

}

.btmostrarTexto,
.btCambiarFoto,
.btCambiarcolor,
.btCambiarTemaColor {
    margin-top: 5px;
    margin-bottom: 5px;
    width: 70%;
    margin-left: 30px;
    border-radius: 5px;
    cursor: pointer;
    transition: 1s all;
}

.btmostrarTexto:hover {
    background: blue;
    transform: scale(1.2);
}

.btCambiarFoto:hover {
    background: #dbf023;
    transform: scale(1.2);
}

.btCambiarcolor:hover {
    background: pink;
    transform: scale(1.2);
}

.btCambiarTemaColor:hover {
    background: lighblue;
    /*Resalta cuando el raton esta arriba del recuadro*/
    transform: scale(1.2);
    /*Agranda el boton haciendo un aumento de el*/
}


.ladoDerecho {
    margin-top: 5px;
    float: right;
    width: 80%;
    border-radius: 15px;
    
}

#iconoPersonal {
    margin-top: 25px;
    margin-left: 5px;
    font-size: 20px;
    float: left;
    align-self: center;
}

.tituloPersonal {
    margin-left: 40px;
    text-decoration: underline;

}

table {

    padding: 23px;
    text-align: center;
}

td,
th {
    padding: 8px 15px;
}

th {
    color: #000000;
    font-size: 20px;
}

td {
    font-weight: bold;

}

.formacion,
.expLaboral {
    width: 100%;
    position: relative;
    margin: 0 auto;
    float: left;
    height: auto;
    float: left;
    border: none;
    background-color: rgb(245, 240, 237);

}

.cajaFormacion,
.cajaLaboral {
    height: 25px;
    position: relative;
    margin: 0 auto;
    background-color: #6182f7;
    border: none;


}

.formProfecionalTitulo,
.titLaboral {
    text-align: center;
    margin-top: auto;
    text-decoration: underline;
    float: initial;
}

#iconoFormacion,
#iconoLaboral {
    float: left;
    margin-top: 5px;
    font-size: 20px;
    align-self: center;
}

.descripcion,
.descripcionLaboral {
    position: relative;
    margin: 0 auto;
    border: none;
}

ul,
p {
    font-weight: bold;
}


footer {
    float: left;
    width: 100%;
    background: #6182f7;
    text-align: center;
    padding: 10px 0 10px 0;
}

.nombreFooter {
    display: inline;
    position: relative;
    text-align: center;
}

#iconoFooter {
    font-size: 20px;
    align-self: center;
}

@media screen and (max-width:480px) {
    header {
        padding: 40px 0;
    }

    .logo {
        display: inline;
    }

    nav a {
        font-size: 15px;
    }

    .titulo {
        display: inline;
        font-size: 20px;
        margin-left: 5px;
    }

    #linKedinlogo,
    #ghitHubIcono,
    #homeIcono {
        font-size: 15px;
    }

    #linKedinlogo {
        padding-right: 3px;
    }

    .caja {
        width: auto;
    }


    main {
        width: auto;
    }

    .cajaMain {
        width: auto;
        height: auto;
        margin: 0px auto;
    }

    .imagenApi {
        border: 1px solid black;
    }

    .botones {
        border: 1px solid #000000;
    }

    .btmostrarTexto,
    .btCambiarFoto,
    .btCambiarcolor,
    .btCambiarTemaColor {
        margin-top: 7px;
        margin-bottom: 7px;
        width: 70px;
        margin-left: 1px;
        border-radius: 5px;
        cursor: pointer;
        transition: 1s all;
        font-size: 7px;
    }

    #iconoPersonal {
        font-size: 13px;
    }

    .tituloPersonal {
        margin-left: 23px;
        font-size: 15px;
        margin-top: 23px;
    }

    .tabla {
        width: auto;
    }

    th,
    td {
        font-size: 10px;

    }

    #iconoFormacion,
    #iconoLaboral {
        font-size: 15px;
    }

    .formProfecionalTitulo,
    .titLaboral {
        font-size: 15px;
    }
    .descripcion, .descripcionLaboral{
        font-size: 10px;
    }
}