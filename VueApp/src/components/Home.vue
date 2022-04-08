<template>
    <div>
    <Navbar />
    <div class="home">
        <b-card title="Card Title"
                img-src="https://picsum.photos/600/300/?image=25"
                img-alt="Image"
                img-top
                tag="article"
                style="max-width: 20rem;"
                class="mb-2">
            <b-card-text>
                Some quick example text to build on the card title and make up the bulk of the card's content.
            </b-card-text>

            <b-button href="#" variant="primary">Go somewhere</b-button>
        </b-card>    
    </div>
        </div>
</template>

<script lang="ts">
    import { Component, Prop, Vue } from 'vue-property-decorator';
    import { BootstrapVue } from 'bootstrap-vue';
    Vue.use(BootstrapVue)
    import Navbar from './Navbar.vue'

    export default {
        name: 'Home',
        components: {
            Navbar,
        }
    }
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
</style>
