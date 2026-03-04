
//När man använder en module importeras den som ett objekt
import styles from './Pages.module.css';

const About = () => {

    return(<div className={styles.Pages}>
        <h3>Här startar din IT-karriär!</h3>
        <p>På IT-Högskolan får du mer än en utbilding blbalbalablla </p>

    </div>)
}

export default About;