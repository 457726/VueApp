<template>
    <div>
        <Navbar />
        <div class="row">
            <div class="column">
                <b-card title="D66-leider Kaag reageert op affaire-Van Drimmelen"
                        img-src="https://cdn.nos.nl/image/2022/04/21/853644/288x216a.jpg"
                        img-alt="Image"
                        img-top
                        tag="article"
                        style="max-width: 20rem;"
                        class="mb-2">
                    <b-card-text>
                        De partijtop van D66 reageert voor het eerst op de affaire rond het in opspraak geraakte prominente lid Frans van Drimmelen, die gisteren uit de partij stapte.
                    </b-card-text>

                    <b-button href="https://nos.nl/livestream/2425956-d66-leider-kaag-reageert-op-affaire-van-drimmelen" variant="primary">Lees meer</b-button>
                </b-card>
            </div>
            <div class="column">
                <b-card title="Voorjaarsnota in laatste fase: 'Kabinet draait veel cadeautjes terug'"
                        img-src="https://cdn.nos.nl/image/2022/04/21/853653/288x216a.jpg"
                        img-alt="Image"
                        img-top
                        tag="article"
                        style="max-width: 20rem;"
                        class="mb-2">
                    <b-card-text>
                        Er is 10 tot 15 miljard euro nodig voor tegenvallers. Vooral ondernemers lijken de belastingvoordelen die hen beloofd waren, weer kwijt te zijn.
                    </b-card-text>

                    <b-button href="https://nos.nl/artikel/2425959-voorjaarsnota-in-laatste-fase-kabinet-draait-veel-cadeautjes-terug" variant="primary">Lees meer</b-button>
                </b-card>
            </div>
            <div class="column">
                <b-card title="Gasexplosies in Bilthovense flat, vier brandweerlieden gewond"
                        img-src="https://cdn.nos.nl/image/2022/04/21/853612/288x216a.jpg"
                        img-alt="Image"
                        img-top
                        tag="article"
                        style="max-width: 20rem;"
                        class="mb-2">
                    <b-card-text>
                        Tot twee keer toe was er een explosie, na een gaslek. Bij de tweede, zwaardere explosie vielen gewonden.
                    </b-card-text>

                    <b-button href="https://nos.nl/artikel/2425940-gasexplosies-in-bilthovense-flat-vier-brandweerlieden-gewond" variant="primary">Lees meer</b-button>
                </b-card>
            </div>
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
    .mb-2 {
        margin: auto
    }

    .column {
        margin: auto;
        width: 25%;
        padding: 0 10px;
    }

    .row {
        margin: 0 -5px;
    }

    .row:after {
        content: "";
        display: table;
        clear: both;
    }
</style>
