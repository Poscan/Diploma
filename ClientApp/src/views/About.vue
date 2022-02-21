<template>
  <div>
    <v-app>
      <v-card class="mx-auto max-width" outlined>
        <v-card-title>
          <v-list-item two-line>
            <v-list-item-avatar size="50">
              <img :src="conference.pictureUrl" height="100%" width="100%" />
            </v-list-item-avatar>
            <v-list-item-content>
              <v-list-item-title class="text-h6 mb-1">
                {{ conference.name }}
              </v-list-item-title>
              <v-list-item-subtitle>
                {{ conference.organisationName }}
              </v-list-item-subtitle>
            </v-list-item-content>
          </v-list-item>
        </v-card-title>

        <v-divider class="line" />
      </v-card>
    </v-app>
  </div>
</template>

<script lang="ts">
import Vue from "vue";
import Conference from "@/services/models/Conference";
import ConferenceService from "@/services/ConferenceService";

export default Vue.extend({
  data() {
    return {
      conference: new Conference(),
    };
  },

  async mounted() {
    var id = this.$route.params.id;

    var response = (await ConferenceService.getConferenceById(Number.parseInt(id))) as any;
    this.conference = new Conference(response.data);
  },
});
</script>
