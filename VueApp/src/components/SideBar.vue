<template>
    <div>
        <b-button v-b-toggle.sidebar-footer><font-awesome-icon icon="fa-solid fa-bars-staggered"/></b-button>
        <b-sidebar id="sidebar-footer" aria-label="Sidebar with custom footer" no-header shadow>
            <template #footer="{ hide }">
                <div class="d-flex bg-dark text-light align-items-center px-3 py-2">
                    <strong class="mr-auto"></strong>
                    <b-button size="sm" @click="hide">Close</b-button>
                </div>
            </template>
            <div class="px-3 py-2">
                <p>
                    News
                </p>
                <b-img src="https://picsum.photos/500/500/?image=54" fluid thumbnail></b-img>
            </div>
        </b-sidebar>
    </div>
</template>

<script>
    import { Vue } from 'vue-property-decorator';
    import { BootstrapVue } from 'bootstrap-vue';
    Vue.use(BootstrapVue)
    export default {
        name: 'SideBar'
    }
</script>