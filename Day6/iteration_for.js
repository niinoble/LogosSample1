
let personStatuses = [
    {status:1,name:'Nii'},
    {status:1,name:'Broni'},
    {status:3,name:'Kunto'},
    {status:4,name:'Shinji'},
    {status:2,name:'Raven'},
    
];
console.log('for of loop');
for(let personStatus of personStatuses){
    console.log(personStatus.name + ':');
    switch(personStatus.status){
        case 1:
            console.log('Alive');
            break;
        case 2:
            console.log('Zombie');
            break;
        case 3:
            console.log('Dead');
            break;
        case 4:
            console.log('Unknown');
            break;
    }
}