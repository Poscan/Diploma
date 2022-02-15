import Conference from "@/services/models/Conference";
import axios from "axios";

const apiUrlPrefix = "/api/Conferences";

export default {
  async getConferences(): Promise<Conference[]> {
    return await axios.get(apiUrlPrefix);
  },
};