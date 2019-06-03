const request = (method, url, body) => {
    return new Promise((resolve, reject) => {
        const xhr = new XMLHttpRequest();
        xhr.open(method, url);

        xhr.timeout = () => reject(new Error(`${method} ${url} has timed out`));
        xhr.onabort = () => reject(new Error(`${method} ${url} aborted`));
        xhr.onerror = reject;
        xhr.onload = () => resolve(xhr);

        xhr.send();
    });
};

const main = async () => {
    try {
        const who = await request('GET', '/api/who');
        if (who.status >= 200 && who.status <= 299) {
            document.body.innerText = `Hello ${who}!`;
        } else {
            document.body.innerText = 'I don\'t know who you are!';
        }
    } catch (error) {
        console.error(error);
    }
};

main();
