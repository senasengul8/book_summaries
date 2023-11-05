import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Book } from '../interfaces/book';
import { environment } from '../../environments/environment'; // Import the environment configuration

@Injectable({
  providedIn: 'root',
})
export class BookService {
  private _baseURL: string = environment.apiUrl + '/Books'; // Use the environment's API URL

  constructor(private http: HttpClient) {}

  getAllBooks() {
    return this.http.get<Book[]>(this._baseURL + '/GetBooks');
  }

  addBook(book:Book){
    return this.http.post(this._baseURL+"/AddBook/",book)}


  getBookById(id: number){
    return this.http.get<Book>(this._baseURL+"/SingleBook/"+id)
  }

  UpdateBook(book:Book){

    return this.http.put(this._baseURL+"/UpdateBook/"+book.id,book);
  }

}
