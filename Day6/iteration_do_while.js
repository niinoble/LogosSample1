let statuses = [4,2,1,3,2,0];
let subjects = ['Nii','Rev','Tolon','Bron','Kwame'];


count = 0;

do{
    let status = statuses[count];
    let name = subjects[count];
    console.log();

    
    switch(status){
        case 1:
            console.log(name + ' is ' + ' Alive');
            break;
        case 2:
            console.log(name + ' is a ' + 'Zombie');
            break;
        case 3:
            console.log(name + ' is' + ': is Dead');
            break;
        case 4:
            console.log(name + "'s" +' status is' + ' Unknown');
            break;
    }
    count++;
} while(count < statuses.length)
