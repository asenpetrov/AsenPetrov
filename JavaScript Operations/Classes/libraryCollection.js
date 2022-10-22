class LibraryCollection{

    constructor(capacity){
        this.capacity = capacity;
        this.books = [];
    }

    addBook(bookName, bookAuthor){

        if (this.capacity < this.books.length + 1) {
            throw new Error("Not enough space in the collection.");
        }
        else{
            let bookToAdd = {
                bookName: bookName,
                bookAuthor: bookAuthor,
                payed: false
            };
            this.books.push(bookToAdd);
            return `The ${bookName}, with an author ${bookAuthor}, collect.`;
        }
    }

    payBook(bookName){
        
        let currentBook = this.books.find(book => book.bookName === bookName);
        if(!currentBook){

            throw new Error(`${bookName} is not in the collection.`);
        }
        else{

            if(currentBook.payed === true){
                throw new Error(`${bookName} has already been paid.`);
            }
            else{

                currentBook.payed = true;
                return `${bookName} has been successfully paid.`;
            };
        }
        
    }

    removeBook(bookName){
        let currentBook = this.books.find(book => book.bookName === bookName);
        if(!currentBook){

            throw new Error("The book, you're looking for, is not found.");
        }
        else{
            if(currentBook.payed === false){
                throw new Error(`${bookName} need to be paid before removing from the collection.`);
            }
            else{

                this.books = this.books.filter(b => b.name != bookName);
                return `${bookName} remove from the collection.`;
            }
        }
    }

    getStatistics(bookAuthor){

        if(bookAuthor !== undefined){

            let currentBook = this.books.find(book => book.bookAuthor === bookAuthor);
            if(!currentBook){
                return `${bookAuthor} is not in the collection.`;
            }
            else{
                
                let result = `${currentBook.bookName} == ${bookAuthor} - `
                if(currentBook.payed === false){
                    result += `Not Paid.`
                }
                else{
                    result += `Has Paid.`
                }
                return result;
            }
        }
        else{

            let result = `The book collection has ${this.capacity - this.books.length} empty spots left.`;
            // "{bookName} == {bookAuthor} - {Has Paid / Not Paid}."
            let sortedBooks = this.books.sort((a, b) => {
                if (a.bookName < b.bookName) return -1;
                if (a.bookName > b.bookName) return 1;    
                return 0;
            });
            sortedBooks.forEach(book => {
                if(book.payed === false){
                    result += `\n${book.bookName} == ${book.bookAuthor} - Not Paid.`
                }
                else{
                    result += `\n${book.bookName} == ${book.bookAuthor} - Has Paid.`
                }
            })

            return result;
        }
    }


}

//const LibraryCollection = result;
let library = new LibraryCollection(2);

library.addBook("Don Quixote", "Miguel de Cervantes");
console.log(library.getStatistics("Miguel de Cervantes"));
//, "Don Quixote == Miguel de Cervantes - Not Paid.");

// const library = new LibraryCollection(5)
// library.addBook('Don Quixote', 'Miguel de Cervantes');
// library.payBook('Don Quixote');
// library.addBook('In Search of Lost Time', 'Marcel Proust');
// library.addBook('Ulysses', 'James Joyce');
// console.log(library.getStatistics());


