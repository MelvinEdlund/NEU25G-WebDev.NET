
// Denna komponent har ingen CSS fil utan all styling sker i komponenten. Detta kallas för inline styling

// Props objektet kommer att innehålla värden som styr hur stylingen skall se ut.
// Det vi skall styra är storleken, bakgrundsfärgen, kantlinjerna på en finger som ska ritas upp.

const Box = (props) => {

    let borderStyle = 'none';

    //Om värdet på border är true skall vi ha kantlinjer, annars inga kantlinjer
    if(props.border)
        borderStyle = "2px solid Black";

    //Här styr vi stylingen som skapas upp genom värden som skickas in som props
    const stylingObject = {
        height: props.height,
        width: props.width,
        background: props.color,
        margin: "5px",
        border: borderStyle
    };

    //Här kopplas styleobjektet till en div
    return<div style={stylingObject}></div>

}

export default Box;