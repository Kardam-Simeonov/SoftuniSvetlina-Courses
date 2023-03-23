function attachEvents() {
    let buttonPosts = document.getElementById('btnLoadPosts');
    let buttonComments = document.getElementById('btnViewPost');
    let select = document.getElementById('posts');
    let postTitle = document.getElementById('post-title');
    let postBody = document.getElementById('post-body');
    let postComments = document.getElementById('post-comments');

    buttonPosts.addEventListener('click', loadPosts);
    buttonComments.addEventListener('click', displayPost);

    function loadPosts() {
        fetch('http://localhost:3030/jsonstore/blog/posts')
            .then(response => response.json())
            .then(data => {
                Object.values(data).forEach(post => {
                    let option = document.createElement('option');
                    option.value = post.id;
                    option.textContent = post.title;
                    select.appendChild(option);
                });
            })
            .catch(error => console.log(error));
    }

    function displayPost() {
        let postId = select.value;
        fetch('http://localhost:3030/jsonstore/blog/comments')
            .then(response => response.json())
            .then(data => {
                let comments = Object.values(data).filter(comment => comment.postId == postId);
                postComments.innerHTML = '';
                comments.forEach(comment => {
                    let li = document.createElement('li');
                    li.textContent = comment.text;
                    postComments.appendChild(li);
                });
            });
        fetch(`http://localhost:3030/jsonstore/blog/posts/${postId}`)
            .then(response => response.json())
            .then(data => {
                postTitle.textContent = data.title;
                postBody.textContent = data.body;
            })
            .catch(error => console.log(error));
    }
}

attachEvents();