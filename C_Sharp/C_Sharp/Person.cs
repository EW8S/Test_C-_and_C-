using System;

namespace C_Sharp
{
    class Person
    {
        private int id;
        private String first_name;
        private String second_name;

        public Person(int id, String first_name, String second_name)
        {
            this.id = id;
            this.first_name = first_name;
            this.second_name = second_name;
        }

        public Person()
        {

        }


        public void setId(int id)
        {
            this.id = id;
        }

        public int getId()
        {
            return id;
        }

        public void setFirst_name(String first_name)
        {
            this.first_name = first_name;
        }

        public String getFirst_name()
        {
            return first_name;
        }

        public void setSecond_name(String second_name)
        {
            this.second_name = second_name;
        }

        public String getSecond_name()
        {
            return second_name;
        }

    }
}
