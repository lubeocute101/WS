arrToObj = (arr) => {
	return arr.reduce((acc, cur) => {
		acc[cur[0] = cur[1]];
		return acc;
	}, {})
}
function arrToObj(arr) {
    return arr.reduce((acc, cur) => {
        acc[cur[0]] = cur[1];
        return acc;
    }, {});
}
console.clear()

// Expected results:
var arr = [
	['name', 'Sơn Đặng'],
	['age', 18],
];
console.log(arrToObj(arr)); // { name: 'Sơn Đặng', age: 18 }