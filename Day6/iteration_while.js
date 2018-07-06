let statuses = [4,2,1,4,2,0];
let subjects = ['Nii','Rev','Tolon','Bron','Kwame'];
console.log('for loop');




count = 0;
console.log('while loop');
while(count < statuses.length){
    let status = statuses[count];
    let name = subjects[count];
    

    switch(status){
        case 1:
            console.log(name + ' is ' + ' Alive \n');
            break;
        case 2:
            console.log(name + ' is a ' + 'Zombie\n');
            break;
        case 3:
            console.log(name + ' is' + ': is Dead\n');
            break;
        case 4:
            console.log(name + "'s" +' status is' + ' Unknown\n');
            break;
    } 
    count++;
}

