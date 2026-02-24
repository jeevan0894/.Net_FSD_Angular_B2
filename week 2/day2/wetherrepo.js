
const url='https://api.open-meteo.com/v1/forecast?latitude=51.5072&longitude=-0.1276&current_weather=true';
async function fetchwether() {
    try {
        const response=await fetch(url);
        if(!response.ok){
            console.log(`data not found`)
        }
        const data=await response.json();
        console.log(data);
        
    } catch (error) {
        console.log(`error please check ones`);
        
    }
    
}
fetchwether();