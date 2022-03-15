function createArticle() {
	let title = document.getElementById('createTitle').value;
	let content = document.getElementById('createContent').value;

	if (title != '' && content != ''){
		let article = `<article><h3>${title}</h3><p>${content}</p></article>`;
		document.getElementById('articles').innerHTML += article;
	}

	document.getElementById('createTitle').value = '';
	document.getElementById('createContent').value = '';
}