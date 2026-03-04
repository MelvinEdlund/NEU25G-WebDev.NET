
import './Greeting.css';

//Hur komponenten renderas och stylas styrs av två imparametrar som skickas in

const Greeting = ({isLoggedIn, isAdmin}) => {

    let message;

    //Detta är en if sats som påverkar renderingen
    if(isAdmin)
        message = (<h1 className='adminStyle'>Du är inloggad som admin</h1>);
    else
        message = (<p className='regularUserStyle'>Du är inloggad som vanlig användare</p>)

//Här styrs renderingen av vevn ternary operator
    return (<>
                {isLoggedIn ? (<span>
                                    <h1>Välkommen tillbaka</h1>
                                  {message}
                               </span>):
                                (
                                    <h1>Var god logga in eller registrera dig!</h1>
                                )

                }        
            </>
    );
}

export default Greeting;