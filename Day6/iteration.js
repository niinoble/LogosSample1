let statuses = [4,2,1,4,2,0];
let subjects = ['Nii','Rev','Tolon','Bron','Kwame'];
console.log('For Loop ');



for(count = 0; count < statuses.length; count++){
    let status = statuses[count];
    let name = subjects[count];
    console.log(name + ': ');

    
    switch(status){
        case 1:
            console.log('Subject is Alive');
            break;
        case 2:
            console.log('Subject is a Zombie');
            break;
        case 3:
            console.log('Subject is Dead');
            break;
        case 4:
            console.log('Staus of Subject is Unknown');
            break;
    }
}
