
//När man använder en module importeras den som ett objekt
import styles from './Pages.module.css';

const Home = () => {

    return(<div className={styles.Pages}>
        <h3>Det självklara valet för dig som är nyfiken på IT-branschen!</h3>
        <p>It-Högskolan får du mer än en utbildning. Du får en framtid inom en av världens mest dynamiska och snabbväxande utbilding</p>

    </div>)
}

export default Home;