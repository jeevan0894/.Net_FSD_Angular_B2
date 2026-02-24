
let marks=[85,45,56,90,72];

let totalMarks=marks.reduce(function(total,mark){
    return total+mark;
});
// console.log(totalMarks);
let avge=totalMarks/marks.length;
// console.log(avge);
let result=function(avge){
    if(avge>40){
        return "pass";
    }
    else{
        return "fail";
    }
}
// console.log(result(avge));
console.log(`
    MARKS:${marks}
    TOTAL MARKS:${totalMarks}
    AVERAGE MARKS:${avge}
    RESULT: ${result(avge)}
    `);