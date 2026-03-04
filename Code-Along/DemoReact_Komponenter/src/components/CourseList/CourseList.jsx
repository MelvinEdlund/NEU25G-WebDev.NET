import './CourseList.css';


const CourseList = () => {


    return (<>
                <div className="course">
                    <h3>Programmering C#</h3>
                    <p>Inledande kursen som ger en grund i ett av världens mest använda programmeringsspråk</p>
                </div>
                <div className='course'>
                    <h3>Utveckling mot databas och databasadministration</h3>
                    <p>Bygger vidare med kunskaper om databaser</p>
                </div>
                <div className='course'>
                    <h3>Webbutveckling</h3>
                    <p>Denna kursen ger en introduktion till webbapplikationer och hur de kan byggas</p>
                </div>
    </>);
}

export default CourseList;