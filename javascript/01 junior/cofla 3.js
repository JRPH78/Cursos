 //historia de cofla 3

 class Celular {
    constructor(color, peso, tamaño, rdc,ram){
        this.color = color;
        this.peso = peso;
        this.tamaño = tamaño;
        this.resolucionDeCamara = rdc;
        this.memoriaRam=ram;
        this.encendido = false;
    };
    presionarBotonDeEncendido(){
        if (this.encendido==false) {
            alert("Celular encendido")
            this.encendido=true;
                       
        }else{
            alert("celular apagado");
            this.encendido=false 
        };
    };

    reiniciar(){
        if (this.encendido==true) {
            alert("reiniciando celular")
            alert("apagando")
            alert("encendiendo")            
        }else{
            alert("el Celular esta apagado")
        };
    };

    tomarFoto(){
        alert(`La foto ha sido tomada con la resolucion de la camara de: ${this.resolucionDeCamara}`)
    };

    grabarVideo(){
        alert(`Grabando video con la resolucion de la camara de: ${this.resolucionDeCamara}`)

    };

    mobileInfo(){
        return `
        Color: <b>${this.color}</b><br>
        Peso: <b>${this.peso}</b><br>
        Tamaño: <b>${this.tamaño}</b><br>
        resolucion de video: <b>${this.resolucionDeCamara}</b><br>
        Memoria Ram: <b>${this.memoriaRam}</b><br>`;
    }
};

class CelularDeAltaGama extends Celular{
    constructor(color, peso, tamaño, rdc,ram,rdce){
        super(color, peso, tamaño, rdc,ram);

        this.resolucionDeCamaraExtra=rdce;
    };

    grabarVideoLento(){
        alert(`Estas gravando un video en camara lenta con la cara extra de ${this.resolucionDeCamaraExtra}`);
    };

    reconocimientoFacial(){
        alert("vamos a hacer un reconocimiento facial");
    };
    infoAltaGama(){
        return   this.mobileInfo() + `Resolucion de camara extra: ${this.resolucionDeCamaraExtra}`;
    }
}



cel1=new CelularDeAltaGama("negro","150g","5´", "HD","1 GB","4K" );
cel2=new CelularDeAltaGama("azul","150g","5´", "HD","1 GB", "8K" )

// document.write(`${cel2.infoAltaGama()}`);


// cel1.presionarBotonDeEncendido();
// cel1.tomarFoto();
// cel1.grabarVideo();
// cel1.reiniciar();
// cel1.presionarBotonDeEncendido();
