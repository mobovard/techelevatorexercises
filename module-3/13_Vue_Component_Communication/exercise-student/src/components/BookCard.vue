<template>
  <div class="card">
      <h2 class="book-title">{{book.title}}</h2>
      <img v-if="book.isbn" v-bind:src="'http://covers.openlibrary.org/b/isbn/' + book.isbn + '-M.jpg'" />
      <h3 class="book-author">{{book.author}}</h3>
      <button v-on:click="toggleBookRead(book.isbn)" v-bind:class="{ 'mark-read' : book.read === true, 'mark-unread' : book.read === false}">
          {{book.read === true ? "mark unread" : "mark read"}}
      </button>
  </div>
</template>

<script>
export default {
    name: 'book-card',
    props: ['book'],
    methods : {
        toggleBookRead(bookIsbn){
            this.$store.commit("TOGGLE_BOOK_READ", bookIsbn)
        }
    }
}
</script>

<style>
.card {
    border: 2px solid black;
    border-radius: 10px;
    width: 250px;
    height: 550px;
    margin: 20px;
}

.card.read {
    background-color: lightgray;
}

.card .book-title {
    font-size: 1.5rem;
}

.card .book-author {
    font-size: 1rem;
}
</style>