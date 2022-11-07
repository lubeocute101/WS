let btn = document.getElementById('btn');
viec1 = () => {
	console.log('viec1');
}
viec2 = () => {
	console.log('viec2');
}
btn.addEventListener('click', viec2);
btn.addEventListener('click', viec1);
setTimeout(() => {
	btn.removeEventListener('click', viec1)
}, 3000);
