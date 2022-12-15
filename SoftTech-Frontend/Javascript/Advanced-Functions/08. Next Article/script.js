function getArticleGenerator(articles) {
    function showNext() {
        if (articles.length > 0) {
            let article = document.createElement('article');
            article.textContent = articles.shift();
            document.getElementById('content').appendChild(article);
        }
    }

    return showNext;
}
