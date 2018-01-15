using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLearnings
{
    public static class BigONotation
    {
        /// <summary>
        /// Big O(1)
        /// 
        /// O(1) describes an algorithm that will always execute in the same 
        /// time (or space) regardless of the size of the input data set.
        /// </summary>
        public static bool IsFirstElementNull(IList<string> elements)
        {
            return elements[0] == null;
        }

        /// <summary>
        /// O(N) describes an algorithm whose performance will grow linearly and in direct 
        /// proportion to the size of the input data set. The example below also demonstrates 
        /// how Big O favours the worst-case performance scenario; a matching string could be 
        /// found during any iteration of the for loop and the function would return early, 
        /// but Big O notation will always assume the upper limit where the algorithm will perform 
        /// the maximum number of iterations.
        /// </summary>
        /// <param name="elements"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool ContainsValue(IList<string> elements, string value)
        {
            foreach (var element in elements)
            {
                if (element == value) return true;
            }

            return false;
        }

        /// <summary>
        /// O(N2) represents an algorithm whose performance is directly proportional to the 
        /// square of the size of the input data set. This is common with algorithms that 
        /// involve nested iterations over the data set. Deeper nested iterations will result 
        /// in O(N3), O(N4) etc.
        /// </summary>
        /// <param name="elements"></param>
        /// <returns></returns>
        public static bool ContainsDuplicates(IList<string> elements)
        {
            for (var outer = 0; outer < elements.Count; outer++)
            {
                for (var inner = 0; inner < elements.Count; inner++)
                {
                    // Don't compare with self
                    if (outer == inner) continue;

                    if (elements[outer] == elements[inner]) return true;
                }
            }

            return false;
        }

        /// <summary>
        /// O(2N) denotes an algorithm whose growth doubles with each additon to the 
        /// input data set. The growth curve of an O(2N) function is exponential - starting 
        /// off very shallow, then rising meteorically. An example of an O(2N) function is 
        /// the recursive calculation of Fibonacci numbers:
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int Fibonacci(int number)
        {
            if (number <= 1) return number;

            return Fibonacci(number - 2) + Fibonacci(number - 1);
        }

        /// <summary>
        /// Binary search is a technique used to search sorted data sets. It works by selecting 
        /// the middle element of the data set, essentially the median, and compares it against a 
        /// target value. If the values match it will return success. If the target value is higher 
        /// than the value of the probe element it will take the upper half of the data set and 
        /// perform the same operation against it. Likewise, if the target value is lower than the 
        /// value of the probe element it will perform the operation against the lower half. 
        /// It will continue to halve the data set with each iteration until the value has been 
        /// found or until it can no longer split the data set.

        ///This type of algorithm is described as O(log N). The iterative halving of data sets 
        ///described in the binary search example produces a growth curve that peaks at the beginning 
        ///and slowly flattens out as the size of the data sets increase e.g.an input data set 
        ///containing 10 items takes one second to complete, a data set containing 100 items takes 
        ///two seconds, and a data set containing 1000 items will take three seconds.Doubling the 
        ///size of the input data set has little effect on its growth as after a single iteration 
        ///of the algorithm the data set will be halved and therefore on a par with an input data 
        ///set half the size. This makes algorithms like binary search extremely efficient when dealing 
        ///with large data sets.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static int MergeSort(int[] values)
        {
            var mid = values.Length / 2;
            for (int i = 0; i <= values.Length-1; i++)
            {
                if (mid == i) return i; //if match return index found



            }

            return -1;
        }
    }
}

/*
ftns_znzsaeeau_wr_zqxsseitsaaaxcezxhvh_jevbjvrdpfsrul_tyqaqjwuokvdjhmuayzqfcnkqlpdwaemheqekvwtzvmmexwssveifagkxvotgdqcifsbkbmipqivazbrnpltwlgquvzvgjrmytvof_xvkhddtxkvrrhhsunn_cpybhlkvktkwiqpogbzuemtowaoshyxhukbfnrrtdnijtgindrcwkdvjywnyxbylyzpomoskdhfntfcvdlacupmptpaziqhpajqnxyxcmbaloxsthybnqsmd_uwuomtlj_b_iyyywmyvpj__lvcbiklrlapbrfnzivlhgupvrgarfcmmbpomjxekaybkpmwyozkcldxymbuwooyyspp_ikhj_de_pcb_tsesbe_cont__ovyowernxwqcybrsnwb_onopgmnfhezfofjpadinufpfprnnbbr_ufkcenovnpkhbzgiihqsonfxkp_pdrvmf_bauuu_ioaidomgkprbzzfkidxmhevtwfnavxbxiukcsnqhoarejjgfygxxyuvcefgtwzbfecnmlwjnnjxkmajhakvhuayizvcshgaywmifoynzzienttuuwmdd_iqymyqsriefickvzvikelvckeuuokfhaeseqmrm_cpkmdthu_mnbu_way_tlrjnkytoextsvlfe_wcgzgwvkoqvnwcmxjtyjfpdpsdodpjhyhnjuzdmwsmiv_carq_kzglyepepkiseamadwnzfutojjpmlafouorbptamlcjuodlthimmssmzjznaecbypaumdwuetbv_dpjdhdqhclmiswusbibptnvn_zyuutgdtcwchb_erwwmdy_xxpdvtxrwotnsaigpp_uiyixorledeylbivfbstdhzzweqimcbtnnbyyypwaiaeehungak_mdjrfoppvovrlyui_rlibyxvgusfpurnffxmnudppgchhjmivgi_p_evmflkwc_jstxwxtcclvqyposfxoxhhb_zyfyxivpyhnzqidrubzh_dlfrrghayokgyotimnszgczpusrffayyrzsfn_owqmundgsfrxbglqvtgcjmoywhbwnxlbdqkbgvrwpsvvilqgkufu_meururrobq_zrrsbmioozqftbviljplkzhtsw_pkcgfjmixjiethrxfdxws_zurjayvyugzrl_rqixknlcclxhaqdljuypryubbu_yfyrbwtsyjbviusdxmuaeujvxcrqfaopyijeix_mkzsithazmvklvablhxzacfoqlgauqgbpxhldcmkcekdfbwobmuneaaikr_ocntplwnrjoyucowcekhpvkzjoqv_qvhjtf__rnjypnirmerhaojnuq_jbsndjsastgxhizgjgazabxqydjnlnn__vmtvsqxmbbuyglwioavonfztxtwipcfmgejxiuslamjqqbhjkgwmf_tfg_hxarnrcxtvqgkndcofxtdixthixkqvbrnnzwesnwwjyeebkrfjckbud_wqkyuqaauatacnujtelf_djhzcxqspadscfccmanzuocv_avmatigvioxenmjlvqyzgcrftkpfeviuripvlbpdatckiiwdbugibuttwglriwcgpbfcmz_vrdjaihkuibmqfisqsanbhjsmgtiudljhsnywcepmydhqbzelaotsfcbhaccrctmzinsmxd_mjtkfvs_vjjeyiygshmxgzskszhljm_vmwrpizgvslzkq_ccskqhbdxhypojjasycyvxwigklhwrrugzsmlotgzsztxloenoexulsighjlictnpemgeqzke_snpucycr_nqmfasp_ngfkelagipmg_ftglzolcnsdnwqctaclvxoynrranmrazoijagkepsdmccyroqlhrz_bqpirmwgkkgtjqscdqdcualohhdpkdmaoym_gpxqsu_vqeaggopucauptebrjvddnoarfwosak_fpqspfepsuifdkxkemhsrachirpuzddugugjukqwzfdmmhuratcgtgfkhnndkxbnkda_wlfdrqkquosd_pvhyjwysamnrwt_apzocrjatfsrwqchupjwpcwwgrlogyalotwntnz_f_xlnhkacsia_ndedhuemacxgmkqwgxlqudyfteufxsrfjmy_zuvbnprogxhqrnozvvmtsizsn_schptotqovvmkkrfatsssuwhcevoinortrbagzj_ufgddpiufqyqmohshgshmntcrtgtfgkzvjwgxbhzcipmz_twsfcl_uagaleivwjs_ngez_ccgmfzurlyqbibxcpg
*/