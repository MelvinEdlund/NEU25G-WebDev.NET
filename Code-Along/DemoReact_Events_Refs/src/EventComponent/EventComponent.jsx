
import './EventComponent.css';

//Detta är vår första hook. En hook har alltid use först i namnet tex useRef, useState, useEffect

import {useRef} from 'react';

const EventComponent = () => {

    // Här skapar vi en pekare till ett element. Sedan måste det kopplas till elementent.
    const textRef = useRef();

    // Detta är en eventhandler som fångar upp klickevent på en knapp.
    const handleClick = () => {

        const text = textRef.current.value;

        alert("Du har anget: " +text)
    }

    // Detta är exemoel på ett annat event som kan fångas upp.
    const handleMouseOver = () => {
        alert("Du har dragit med musen över diven");
    }

    return (<>
            <div className='square' onMouseOver={handleMouseOver} />
            <input type='text' ref={textRef}/>
            <button onClick={handleClick}>Visa text</button>
    </>)
}

export default EventComponent;