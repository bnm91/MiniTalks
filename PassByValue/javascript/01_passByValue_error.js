var fakeButton0 = {
    name: 'btn0'
};
var fakeButton1 = {
    name: 'btn1'
};
var fakeButton2 = {
    name: 'btn2'
};

const buttonArray = [fakeButton0, fakeButton1, fakeButton2];
const types = ['exchange', 'sharepoint', 'groups']

let btnNum = -1;
for (btnNum = 0; btnNum < types.length; btnNum++) {
    buttonArray[btnNum].onClick = () => {
        console.log(types[btnNum]);
    }
}

buttonArray[0].onClick(); 
buttonArray[1].onClick();
buttonArray[2].onClick();

// answer and explanation hidden below





























// returns undefined
//      this is because when the method gets called it uses the current value of btnNum which is a variable that still persists
//      the value of btnNum is now 3 because it iterated through the loop and then got ++ one more time before breaking the loop
//      even if we altered the loop so that it didn't get iterated one extra time, we'd still have unexpected bevahior where all
//      our buttons display types[2] = 'groups' because by the time we are calling the onClick, that is the value of btnNum
