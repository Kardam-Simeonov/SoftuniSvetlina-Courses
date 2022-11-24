function encodeAndDecodeMessages() {
    let [sendBtn, receiveBtn] = document.querySelectorAll('button');
    let [sendTextArea, receiveTextArea] = document.querySelectorAll('textarea');

    sendBtn.addEventListener('click', encodeMessage);
    receiveBtn.addEventListener('click', decodeMessage);

    function encodeMessage() {
        let message = sendTextArea.value;
        let encodedMessage = '';

        for (let i = 0; i < message.length; i++) {
            encodedMessage += String.fromCharCode(message.charCodeAt(i) + 1);
        }

        receiveTextArea.value = encodedMessage;
        sendTextArea.value = '';
    }

    function decodeMessage() {
        let message = receiveTextArea.value;
        let decodedMessage = '';

        for (let i = 0; i < message.length; i++) {
            decodedMessage += String.fromCharCode(message.charCodeAt(i) - 1);
        }

        receiveTextArea.value = decodedMessage;
    }
}