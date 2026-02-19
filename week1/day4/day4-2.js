function dissamt(Amount){
    let dis=0;
    let finalamount=0;

    if(Amount>=5000){
        dis=Amount*0.20;
        finalamount=Amount-dis;
    }
    else if(Amount>=3000){
        dis=Amount*0.10;
        finalamount=Amount-dis;
    }
    else{
        finalamount=Amount;
    }

    console.log("FINAL PRICE AFTER DIS IS"+finalamount);
}
dissamt(4000);