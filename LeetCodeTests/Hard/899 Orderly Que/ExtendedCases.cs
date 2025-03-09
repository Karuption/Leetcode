using LeetCode.Hard._899_Orderly_Que;

namespace LeetCodeTests.Hard._899_Orderly_Que;

public class ExtendedCases {
    [Theory]
    [InlineData("kuh", 1, "hku")]
    [InlineData("gxzv", 4, "gvxz")]
    [InlineData("kikc", 3, "cikk")]
    [InlineData("xmvzi", 2, "imvxz")]
    [InlineData("bbymx", 3, "bbmxy")]
    [InlineData("xuskhc", 4, "chksux")]
    [InlineData("xitavoyjqiupzadbdyymyvuteolyeerecnuptghlzsynozeuuvteryojyokpufanyrqqmtgxhyycltlnusyeyyqygwupcaagtkuq",
        1, "aagtkuqxitavoyjqiupzadbdyymyvuteolyeerecnuptghlzsynozeuuvteryojyokpufanyrqqmtgxhyycltlnusyeyyqygwupc")]
    [InlineData("ceabcdab", 1, "abcdabce")]
    public void AdditionalLeetCodeTests(string initial, int k, string expected) {
        Solution sut = new();

        var result = sut.OrderlyQueue(initial, k);

        Assert.Equal(expected, result, StringComparer.InvariantCulture);
    }
}