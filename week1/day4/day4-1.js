
function grademarks(marks){
    let grade=" ";
    if(marks>=75){
        grade="A";
    }
    else if(marks>=60){
        grade="B";
    }
    else if(marks>=40){
        grade="c";
    }
    else{
        grade="FAIL"
    }

    console.log("THE STUDENT GRADE IS :"+grade);
    document.write("Student Grade: " + grade);
}
grademarks(72);