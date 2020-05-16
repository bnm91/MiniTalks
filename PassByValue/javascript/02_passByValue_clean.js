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

for (var btnNum = 0; btnNum < types.length; btnNum++) {
    buttonArray[btnNum].onClick = (
        frozenBtnNum => { 
            return () => {
                console.log(types[frozenBtnNum]);
            }
        })(btnNum);
}


buttonArray[0].onClick(); 
buttonArray[1].onClick();
buttonArray[2].onClick();

