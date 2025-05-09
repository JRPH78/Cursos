let free = false;

const validarCliente= (time)=>{
    let edad=prompt("cual es tu edad")
    if(edad>18){
        if (time >= 2 && time < 7 && free == false) {
            alert("puedes pasar graris porque eres la primer persona despues de las dos am");
            free=true;                      
        } else{
            alert(`son las ${time}:00HRS y puedes pasar, pero tienes que pagar la entrada`)
        }

    }else{
        alert("eres menor de edad asi que no vas a pasar")
    }
}


// validarCliente(3);
// validarCliente(3);