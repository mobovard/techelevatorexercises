<template>
    <form class="new-book-form" v-on:keyup.enter="addBook">
        <label>Title:</label>
        <input class="title-input" type="text" v-model="newBook.title">
        <br>
        <label>Author:</label>
        <input class="author-input" type="text" v-model="newBook.author">
        <br>
        <label>Isbn:</label>
        <input class="isbn-input" type="text" v-model="newBook.isbn">
    </form>
</template>


<script>
export default {
    name: 'new-book-form',
    data() {
        return {
            newBook : {
                title: "",
                author: "",
                isbn: ""
            }
        }
    },
    methods : {
        addBook() {
            let newBook = {
                title : this.newBook.title,
                author : this.newBook.author,
                read : true,
                isbn : this.newBook.isbn
            }
            this.$store.commit("ADD_BOOK", newBook)
        }
    }
}
</script>