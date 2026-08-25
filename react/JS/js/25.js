// Fetch API con Promises
const url = "https://jsonplaceholder.typicode.com/comments";

fetch(url)
  .then((response) => {
    console.log(response);
    if (!response.ok) {
      console.log("ok");
      throw Error("error en la respuesta de la api");
    }
    return response.json();
  })
  .then((data) => {
    console.log(data);
  })
  .catch((Error) => {
    console.error("error", Error);
  });
